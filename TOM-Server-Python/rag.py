import json
from query_vector_db import get_top_recommendations
from generate_response import generate_response

def run_rag_pipeline(query, top_k=3):
    """
    Executes the RAG workflow: retrieves relevant data and generates a human-readable response.

    Parameters:
        query (str): The user's query.
        top_k (int): Number of top recommendations to retrieve.

    Returns:
        dict: Contains the recommendations and the generated response.
    """
    with open("scraped_products.json", "r") as f:
        scraped_data = json.load(f)

    recommendations = get_top_recommendations(query, scraped_data, top_k=top_k)

    response = generate_response(query, recommendations)

    return {
        "query": query,
        "recommendations": recommendations,
        "response": response,
    }

if __name__ == "__main__":
    user_query = "Find affordable shirts near me"
    result = run_rag_pipeline(user_query)

    print("Query:", result["query"])
    print("Recommendations:", json.dumps(result["recommendations"], indent=2))
    print("Generated Response:", result["response"])