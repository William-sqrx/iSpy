from sentence_transformers import SentenceTransformer
import faiss
import numpy as np
import json
import boto3

model = SentenceTransformer("all-MiniLM-L6-v2")

s3 = boto3.client("s3")
S3_BUCKET = "my-real-s3-bucket"

def process_and_store_embeddings():
    with open("scraped_products.json", "r") as f:
        scraped_data = json.load(f)

    index = faiss.IndexFlatL2(384)
    embeddings = []

    for product in scraped_data:
        text = f"{product['name']} | {product['price']} | {product['location']} | {product['url']}"
        embedding = model.encode(text)
        embeddings.append(embedding)

    embeddings = np.array(embeddings)
    index.add(embeddings)

    faiss.write_index(index, "faiss_index.bin")

    s3.upload_file("faiss_index.bin", S3_BUCKET, "faiss_index_latest.bin")
    print("FAISS index uploaded to S3.")