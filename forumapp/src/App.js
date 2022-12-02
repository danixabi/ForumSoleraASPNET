import logo from "./logo.svg";
import "./App.css";
import HomePage from "./components/HomePage";
import { BrowserRouter, Link, Route, Routes } from "react-router-dom";
import ThreadsCatalog from "./components/ThreadsCatalog";
import Post from "./components/Post";
import Thread from "./components/Thread";

function App() {
  <BrowserRouter>
    <Routes>
      <Route path="/">
        <HomePage />
      </Route>
      <Route path="/ThreadCatalog">
        <ThreadsCatalog />
      </Route>
      <Route path="/Thread">
        <Thread />
      </Route>
      <Route path="/Thread/Post">
        <Post />
      </Route>
    </Routes>
  </BrowserRouter>;

  return (
    <div>
      <HomePage />
    </div>
  );
}

export default App;
