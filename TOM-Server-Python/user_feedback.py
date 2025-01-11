def store_feedback(user_id, item_id, liked):
    import sqlite3

    # Connect to your database
    conn = sqlite3.connect("server_database.db")
    cursor = conn.cursor()

    # Insert feedback
    cursor.execute(
        "INSERT INTO feedback (user_id, item_id, liked) VALUES (?, ?, ?)",
        (user_id, item_id, liked),
    )
    conn.commit()
    conn.close()