import React from "react";
import Navbar from "./NavBar";
import { Link } from "react-router-dom";
import { Button } from "react-bootstrap";

const Topics = () => {
  return (
    <div>
      <div>
        <Navbar />
      </div>
      <div>
        <Button variant="primary">
          <Link to={"/Thread"}> Topic1</Link>
        </Button>
        <Button className="primary">
          <Link to={"/Thread"}> Topic2</Link>
        </Button>
        <Button className="primary">
          <Link to={"/Thread"}> Topic3</Link>
        </Button>
      </div>
    </div>
  );
};

export default Topics;
