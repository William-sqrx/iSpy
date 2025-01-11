import sqlite3

def log_feedback(user_id, product_id, feedback):
    """
    Logs user feedback (like/dislike) into a database.
    """
    conn = sqlite3.connect("feedback.db")
    cursor = conn.cursor()

    # Create table if it doesn't exist
    cursor.execute("""
        CREATE TABLE IF NOT EXISTS feedback (
            user_id INTEGER,
            product_id TEXT,
            feedback TEXT,
            timestamp DATETIME DEFAULT CURRENT_TIMESTAMP
        )
    """)

    # Insert feedback
    cursor.execute("INSERT INTO feedback (user_id, product_id, feedback) VALUES (?, ?, ?)", (user_id, product_id, feedback))
    conn.commit()
    conn.close()