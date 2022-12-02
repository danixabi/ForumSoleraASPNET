import "./App.css";
import HomePage from "./components/HomePage";
import { BrowserRouter, Navigate, Route, Routes } from "react-router-dom";
import Topics from "./components/Topics";
import Post from "./components/Post";
import Thread from "./components/Thread";
import LoginPage from "./components/LoginPage";

  return (
    <div>
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<HomePage />} />
          <Route path="/Topics" element={<Topics />} />
          <Route path="/Thread" element={<Thread />} />
          <Route path="/Thread/Post" element={<Post />} />
          <Route path="/Login" element={<LoginPage />} />
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
