import { useState } from "react";
import "./App.css";
import "bootstrap/dist/css/bootstrap.css";

function App() {
  let [tytulFilmu, setTytulFilmu] = useState("");
  let [rodzajFilmu, setRodzajFilmu] = useState(0);
  return (
    <>
      <form onSubmit={(e) => e.preventDefault()}>
        <div className="form-group">
          <label htmlFor="tytulFilmu">Tytuł filmu</label>
          <input
            type="text"
            className="form-control"
            id="tytulFilmu"
            onChange={(e) => setTytulFilmu(e.target.value)}
          />
        </div>
        <div className="form-group">
          <label htmlFor="rodzajFilmu">Rodzaj</label>
          <select
            className="form-control"
            id="rodzajFilmu"
            onChange={(e) => setRodzajFilmu(e.target.value)}
          >
            <option></option>
            <option value={1}>Komedia</option>
            <option value={2}>Obyczajowy</option>
            <option value={3}>Sensacyjny</option>
            <option value={4}>Horror</option>
          </select>
        </div>
        <div className="form-group">
          <button
            type="submit"
            className="btn btn-primary"
            onClick={() =>
              console.log(`tytul: ${tytulFilmu}; rodzaj: ${rodzajFilmu}`)
            }
          >
            Success
          </button>
        </div>
      </form>
    </>
  );
}

export default App;
