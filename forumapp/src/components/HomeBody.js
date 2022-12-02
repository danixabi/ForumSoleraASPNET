import React from "react";
import { Button } from "react-bootstrap";
import { Link } from "react-router-dom";

const HomeBody = () => {
  return (
    <div>
      <div>
        <h2>Welcome to Solera Forum!</h2>
        <h3>Enjoy posting everything you want!</h3>
        <button variant="primary">
          <Link href="/ThreadCatalog">View Threads</Link>
        </button>
      </div>
    </div>
  );
};

export default HomeBody;
