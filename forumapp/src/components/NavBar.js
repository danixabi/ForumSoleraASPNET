import { Link } from "react-router-dom";
import "./NavBar.css";

const Navbar = (props) => {
  return (
    <div className="navbar">
      <div className="navContainer">
        <span className="logo">SoleraForum.com</span>
        <div className="navItems">
          <button className="navButton">
            <Link to="/">Home</Link>
          </button>
          <button className="navButton">
            <Link to="/Topics">Topics</Link>
          </button>
          <button className="navButton">
            <Link to="/Login">Log Out</Link>
          </button>
        </div>
      </div>
    </div>
  );
};

export default Navbar;
