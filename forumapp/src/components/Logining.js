import React from "react";
import { useState } from "react";
import { Link } from "react-router-dom";

const Logining = (props) => {
  const [user, setUser] = useState(props);
  const [password, setPassword] = useState(props);
  return console.warn("user: " + user, "password: " + password);
  <Link to="/"></Link>;
};

export default Logining;
