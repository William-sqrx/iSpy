
# **TOM Enhanced Recommendation System**

The **TOM Enhanced Recommendation System** is a sophisticated platform that provides **personalized product recommendations** by integrating **real-time user data**, **web scraping**, and **AI-driven insights**. Built on top of the **TOM Server Python**, this system leverages cutting-edge technologies like **RAG (Retrieval-Augmented Generation)** to deliver recommendations based on a user’s preferences, location, and real-time product availability.

This platform is ideal for **smart devices**, such as AR glasses, where users can:
- Receive personalized shopping suggestions.
- Get real-time recommendations tailored to their location and time.
- Hear AI-generated recommendations via text-to-speech.

---

## **Features**
1. **Web Scraping**: Collect product data (e.g., prices, availability, and locations) from real e-commerce websites.
2. **Embedding Vector Database**: Process product data into embeddings stored in a FAISS vector database backed by AWS S3.
3. **RAG Pipeline**: Combine retrieval and generation to deliver contextual recommendations using FAISS and OpenAI GPT.
4. **Text-to-Speech (TTS)**: Convert AI-generated recommendations into speech using ElevenLabs.
5. **User Feedback Integration**: Capture user feedback to refine recommendations.
6. **Real-Time User Data API**: Manage user preferences and location dynamically using FastAPI.

---

## **Project Structure**
```
├── README.md                # Project instructions
├── scrapy_spider.py         # Web scraping script
├── data_processing.py       # Embedding creation and FAISS index storage
├── query_vector_db.py       # FAISS query and retrieval
├── generate_response.py     # GPT-based response generation
├── text_to_speech.py        # ElevenLabs TTS integration
├── user_api.py              # FastAPI server for user data management
├── feedback.py              # User feedback logging and storage
├── rag.py                   # Complete RAG pipeline
├── requirements.txt         # Python dependencies
└── scraped_products.json    # Example scraped product data (auto-generated)
```

---

## **Setup Instructions**

### **Step 1: Clone the Repository**
```bash
git clone https://github.com/William-sqrx/iSpy.git
cd iSpy
```

### **Step 2: Set Up TOM Server Python**
Follow the instructions in the **TOM Server Python** directory's README to set up the base server.

### **Step 3: Install Dependencies**
1. Create a Python virtual environment:
   ```bash
   python3 -m venv env
   source env/bin/activate  # For Windows: env\Scripts\activate
   ```

2. Install required Python libraries:
   ```bash
   pip install -r requirements.txt
   ```

### **Step 4: Configure Environment Variables**
Create a `.env` file in the root directory and add the following:
```env
OPENAI_API_KEY=your-openai-api-key
ELEVENLABS_API_KEY=your-elevenlabs-api-key
AWS_ACCESS_KEY_ID=your-aws-access-key
AWS_SECRET_ACCESS_KEY=your-aws-secret-key
AWS_S3_BUCKET=your-s3-bucket-name
```

---

## **Usage Instructions**

### **1. Web Scraping**
Run the Scrapy spider to scrape product data:
```bash
scrapy crawl products
```
The scraped data will be saved to `scraped_products.json`.

---

### **2. Process and Store Embeddings**
Convert the scraped data into embeddings and store them in FAISS and S3:
```bash
python data_processing.py
```

---

### **3. Query Recommendations**
Query the FAISS index for top recommendations based on a user query:
```python
from query_vector_db import get_top_recommendations

query = "Find affordable shirts near me"
with open("scraped_products.json", "r") as f:
    scraped_data = json.load(f)

recommendations = get_top_recommendations(query, scraped_data, top_k=3)
print(recommendations)
```

---

### **4. Run the RAG Pipeline**
Execute the full retrieval-augmented generation (RAG) workflow:
```python
from rag import run_rag_pipeline

query = "Find affordable groceries near me"
result = run_rag_pipeline(query)

print("Query:", result["query"])
print("Recommendations:", result["recommendations"])
print("Response:", result["response_text"])
```

---

### **5. Generate Text-to-Speech**
Convert the generated response into an audio file:
```python
from text_to_speech import text_to_speech

response = "We recommend the following products..."
text_to_speech(response, output_file="recommendations.mp3")
```

---

### **6. Real-Time User Data API**
Start the FastAPI server to manage user preferences and location:
```bash
uvicorn user_api:app --reload
```

#### Example API Calls
- **Update user location**:
  ```bash
  curl -X POST "http://127.0.0.1:8000/update_location"        -H "Content-Type: application/json"        -d '{"user_id": 1, "lat": 1.3521, "lon": 103.8198}'
  ```

- **Update user preferences**:
  ```bash
  curl -X POST "http://127.0.0.1:8000/update_preferences"        -H "Content-Type: application/json"        -d '{"user_id": 1, "preferences": ["shirts", "groceries"]}'
  ```

---

## **Feedback Integration**
Log user feedback to improve future recommendations:
```python
from feedback import log_feedback

# Log feedback for a specific product
log_feedback(user_id=1, product_id="product_123", feedback="liked")
```

---

## **Example Workflow**
1. Scrape product data from e-commerce websites.
2. Convert product data into embeddings and store them in FAISS (backed by S3).
3. Query the vector database for top recommendations using RAG.
4. Generate a human-readable response using GPT.
5. Convert the response into speech using ElevenLabs.
6. Collect user feedback to refine future recommendations.

---

## **Dependencies**
- **Scrapy**: For web scraping.
- **SentenceTransformers**: To generate embeddings.
- **FAISS**: For vector-based similarity search.
- **boto3**: To interact with AWS S3.
- **OpenAI GPT**: For generating human-readable recommendations.
- **ElevenLabs API**: For text-to-speech.
- **FastAPI**: To handle user data via APIs.

Install all dependencies with:
```bash
pip install -r requirements.txt
```

---

## **Contributing**
We welcome contributions! Please open an issue or submit a pull request for any suggestions or improvements.

---

## **License**
This project is licensed under the MIT License.
