import React from "react";
import Navbar from "./NavBar";
import { useState } from "react";
import { Form } from "react-bootstrap";

const Post = () => {
  return (
    <div>
      <div>
        <Navbar />
      </div>
      <Form>
        <label>
          <input type="text" name="Title"></input>
        </label>
      </Form>
    </div>
  );
};

export default Post;
