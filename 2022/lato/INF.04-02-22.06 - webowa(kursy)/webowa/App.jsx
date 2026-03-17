import { useState } from "react";
import "bootstrap/dist/css/bootstrap.css";
function App() {
  const [imieiNazwisko, setImieINazwisko] = useState("");
  const [wybranyNrKursu, setWybranyNrKursu] = useState(0);

  let kursy = [
    "Programowanie w C#",
    "Angular dla początkujących",
    "Kurs Django",
  ];
  function handleSubmit(e) {
    e.preventDefault();
    if (wybranyNrKursu > 0 && wybranyNrKursu <= kursy.length) {
      console.log(imieiNazwisko + " " + kursy[wybranyNrKursu - 1]);
    } else {
      console.log("Nieprawidłowy Numer Kursu");
    }
  }

  return (
    <>
      <h2>Liczba Kursów: {kursy.length}</h2>
      <ol>
        {kursy.map((e, index) => (
          <li key={index}>{e}</li>
        ))}
      </ol>
      <form onSubmit={handleSubmit}>
        <div className="form-group">
          <label htmlFor="imieNazwisko">Imię i nazwisko</label>
          <input
            className="form-control"
            type="text"
            id="imieNazwisko"
            onChange={(e) => setImieINazwisko(e.target.value)}
          />
        </div>
        <br />
        <div className="form-group">
          <label htmlFor="nrKurs">nr kursu</label>
          <input
            className="form-control"
            type="number"
            id="nrKurs"
            onChange={(e) => setWybranyNrKursu(parseInt(e.target.value) || 0)}
          />
        </div>
        <button className="btn btn-primary" type="submit">
          Zapisz Do Kursu
        </button>
      </form>
    </>
  );
}
// kursy[wybranyNrKursu - 1]
//   ? kursy[wybranyNrKursu - 1]
//   : "Nieprawidłowy Numer Kursu";

// onClick={() =>
//             console.log(
//               imieiNazwisko +
//                 " " +
//                 (wybranyNrKursu > 0 && wybranyNrKursu <= kursy.length
//                   ? kursy[wybranyNrKursu - 1]
//                   : "Nieprawidłowy Numer Kursu")
//             )
//           }
export default App;
