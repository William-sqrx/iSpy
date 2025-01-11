import requests

ELEVENLABS_API_KEY = "your-elevenlabs-api-key"

def text_to_speech(text, output_file="recommendation.mp3"):
    url = "https://api.elevenlabs.io/v1/text-to-speech"
    headers = {
        "Authorization": f"Bearer {ELEVENLABS_API_KEY}",
        "Content-Type": "application/json",
    }
    payload = {"text": text, "voice_settings": {"stability": 0.8, "similarity_boost": 0.9}}

    response = requests.post(url, json=payload, headers=headers)
    with open(output_file, "wb") as f:
        f.write(response.content)
    print(f"Speech saved to {output_file}")