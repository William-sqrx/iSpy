import openai

# OpenAI API key
openai.api_key = "your-openai-api-key"

def generate_response(query, recommendations):
    prompt = f"""User Query: {query}
    Recommendations:
    """
    for i, rec in enumerate(recommendations, 1):
        prompt += f"{i}. {rec['name']} at {rec['price']} from {rec['location']}. See more: {rec['url']}\n"

    prompt += "Provide a user-friendly summary for these recommendations."
    response = openai.Completion.create(
        model="text-davinci-003",
        prompt=prompt,
        max_tokens=200,
        temperature=0.7,
    )
    return response["choices"][0]["text"]