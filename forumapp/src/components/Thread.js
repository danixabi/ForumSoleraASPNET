import React from "react";
import Navbar from "./NavBar";
import { Form } from "react-bootstrap";
import { useState } from "react";
import { useNavigate } from "react-router-dom";

const Thread = () => {
  const navigate = useNavigate();
  var UsedTitles = ["Software", "PC Building"];
  const [title, setTitle] = useState("");
  function VerifyTitle() {
    setTitle(document.getElementById("title").value);

    //console.log(title);
    const found = UsedTitles.find((list) => list === title);
    console.log(list);
    if (found) {
      console.log("Repetido");
      console.log("used titles: " + UsedTitles);
    } else {
      //navigate("/Thread/Post");
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
