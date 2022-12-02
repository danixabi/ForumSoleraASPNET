import React from "react";
import Navbar from "./NavBar";
import { Form } from "react-bootstrap";
import { useState } from "react";
import { useNavigate } from "react-router-dom";

const Thread = () => {
  const navigate = useNavigate();
  const UsedTitles = ["Software", "PC Building"];
  const [title, setTitle] = useState("");
  function onChange(e) {
    setTitle(e.target.value);
  }
  function VerifyTitle() {
    const found = UsedTitles.find(
      (list) => list.toLowerCase() === title.toLowerCase()
    );

    if (found) {
      alert("Repited try again");
      console.log("Repetido");
      console.log("used titles: " + UsedTitles);
    } else {
      UsedTitles.push(title);
      navigate("/Thread/Post");
    }
  }

  return (
    <div>
      <div>
        <Navbar />
      </div>
      <div>
        <Form>
          <label>
            <input
              typeof="text"
              name="Title"
              placeholder="Post Title"
              id="title"
              onChange={onChange}
            ></input>
          </label>
          <button type="button" onClick={VerifyTitle}>
            Verify Title
          </button>
        </Form>
      </div>
    </div>
  );
};

export default Thread;
