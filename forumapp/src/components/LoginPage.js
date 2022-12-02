import React from "react";
import { Form } from "react-bootstrap";
import { useState } from "react";
import Logining from "./Logining";

const LoginPage = (props) => {
  const [user, setUser] = useState("");
  const [password, setPassword] = useState("");

  function Logining() {
    console.log("user: " + user, "password: " + password);
  }

  return (
    <div>
      <div>
        <Form>
          <label>
            <input
              type="text"
              placeholder="User"
              onChange={(e) => setUser(e.target.value)}
              name="user"
            />
          </label>
          <label>
            <input
              type="password"
              placeholder="Password"
              onChange={(e) => setPassword(e.target.value)}
              name="password"
            />
          </label>
          <button onClick={Logining} type="submit" value="Submit" />
        </Form>
      </div>
    </div>
  );
};

export default LoginPage;
