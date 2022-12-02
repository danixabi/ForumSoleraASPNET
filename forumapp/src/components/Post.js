import React, { useState } from "react";
import Navbar from "./NavBar";
import { Form } from "react-bootstrap";
import { useNavigate } from "react-router-dom";

const Post = () => {
  const navigate = useNavigate();
  const BadWords = ["puta", "mierda"];
  const [BodyPost, setBodyPost] = useState("");
  function checkBadWords(e) {
    setBodyPost(e.target.value);

    const found = BadWords.find(
      (list) => list.toLowerCase() === BodyPost.toLowerCase()
    );
    if (found) {
      alert("Bad Word Detected");
    } else {
      alert("Post OK and Posted");
      navigate("/");
    }
  }

  return (
    <div>
      <div>
        <Navbar />
      </div>
      <Form>
        <label>
          <select name="PostCategory" id="PostCategory">
            <option value="1">question</option>
            <option value="2">suggestion</option>
            <option value="3">clarification</option>
          </select>
        </label>
        <br />
        <label>
          <textarea
            type="textfield"
            name="Title"
            placeholder="Body Post"
          ></textarea>
        </label>
        <br />
        <label>
          <img alt={"ImgAlt"}></img>
        </label>
        <br />
        <label>
          <button type="button" onClick={checkBadWords}>
            POST
          </button>
        </label>
      </Form>
    </div>
  );
};

export default Post;
