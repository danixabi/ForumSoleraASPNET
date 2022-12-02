import React from "react";
import { Form } from "react-bootstrap";
import { useState } from "react";
import { useNavigate } from "react-router-dom";

const LoginPage = (props) => {
  const [user, setUser] = useState("");
  const [password, setPassword] = useState("");
  const navigate = useNavigate();

  const selectUser = (e) => {
    setUser(e.target.value);
  };
  const selectPass = (e) => {
    setPassword(e.target.value);
  };
  function Verify() {
    if (user === "usuario1" && password === "usuario1") {
      navigate("/");
      console.log("Bienvenido Usuario1");
    } else if (user === "usuario2" && password === "usuario2") {
      navigate("/");
      console.log("Bienvenido Usuario2");
    } else {
      navigate("/Login");
      console.log("Bad Login try again");
    }
  }

  return (
    <div>
      <div>
        <Form>
          <label>
            <input
              type="text"
              placeholder="User"
              onChange={selectUser}
              name="user"
            />
          </label>
          <label>
            <input
              type="password"
              placeholder="Password"
              onChange={selectPass}
              name="password"
            />
          </label>
          <button onClick={Verify} type="button">
            Sign In
          </button>
        </Form>
      </div>
    </div>
  );
};

export default LoginPage;
