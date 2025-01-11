from fastapi import FastAPI, HTTPException

app = FastAPI()

user_data = {}

@app.post("/update_location")
def update_location(user_id: int, lat: float, lon: float):
    user_data[user_id] = {"lat": lat, "lon": lon}
    return {"message": "Location updated successfully", "data": user_data[user_id]}

@app.get("/get_location/{user_id}")
def get_location(user_id: int):
    if user_id not in user_data:
        raise HTTPException(status_code=404, detail="User not found")
    return user_data[user_id]

@app.post("/update_preferences")
def update_preferences(user_id: int, preferences: list[str]):
    if user_id not in user_data:
        user_data[user_id] = {}
    user_data[user_id]["preferences"] = preferences
    return {"message": "Preferences updated successfully", "data": user_data[user_id]}