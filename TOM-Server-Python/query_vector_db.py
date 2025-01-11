import faiss
import numpy as np
import boto3
import json
from sentence_transformers import SentenceTransformer

s3 = boto3.client("s3")
MODEL = SentenceTransformer("all-MiniLM-L6-v2")
S3_BUCKET = "my-real-s3-bucket"

def load_index_from_s3():
    # Download FAISS index from S3
    s3.download_file(S3_BUCKET, "faiss_index_latest.bin", "faiss_index.bin")
    index = faiss.read_index("faiss_index.bin")
    return index

def get_top_recommendations(query, scraped_data, top_k=3):
    # Load FAISS index
    index = load_index_from_s3()

    # Query embedding
    query_embedding = MODEL.encode(query).reshape(1, -1)

    # Search the index
    distances, indices = index.search(query_embedding, k=top_k)

    # Retrieve products based on indices
    recommendations = [scraped_data[i] for i in indices[0]]
    return recommendations