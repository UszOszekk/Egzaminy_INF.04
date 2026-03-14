import { useState } from "react";
import "./App.css";
import "bootstrap/dist/css/bootstrap.css";

function App() {
  let [kwiaty, setKwiaty] = useState(true);
  let [zwierzeta, setZwierzeta] = useState(true);
  let [samochody, setSamochody] = useState(true);
  let [zdjecia, setZdjecia] = useState([
    { id: 0, alt: "Mak", filename: "obraz1.jpg", category: 1, downloads: 35 },
    {
      id: 1,
      alt: "Bukiet",
      filename: "obraz2.jpg",
      category: 1,
      downloads: 43,
    },
    {
      id: 2,
      alt: "Dalmatyńczyk",
      filename: "obraz3.jpg",
      category: 2,
      downloads: 2,
    },
    {
      id: 3,
      alt: "Świnka morska",
      filename: "obraz4.jpg",
      category: 2,
      downloads: 53,
    },
    {
      id: 4,
      alt: "Rotwailer",
      filename: "obraz5.jpg",
      category: 2,
      downloads: 43,
    },
    { id: 5, alt: "Audi", filename: "obraz6.jpg", category: 3, downloads: 11 },
    { id: 6, alt: "kotki", filename: "obraz7.jpg", category: 2, downloads: 22 },
    { id: 7, alt: "Róża", filename: "obraz8.jpg", category: 1, downloads: 33 },
    {
      id: 8,
      alt: "Świnka morska",
      filename: "obraz9.jpg",
      category: 2,
      downloads: 123,
    },
    {
      id: 9,
      alt: "Foksterier",
      filename: "obraz10.jpg",
      category: 2,
      downloads: 22,
    },
    {
      id: 10,
      alt: "Szczeniak",
      filename: "obraz11.jpg",
      category: 2,
      downloads: 12,
    },
    {
      id: 11,
      alt: "Garbus",
      filename: "obraz12.jpg",
      category: 3,
      downloads: 321,
    },
  ]);
  function pobierz(index) {
    let temp = [...zdjecia];
    temp[index].downloads++;
    setZdjecia(temp);
  }
  return (
    <>
      <h1>Kategorie zdjęć</h1>

      <div className="form-check-inline  form-switch">
        <input
          className="form-check-input"
          type="checkbox"
          name="kwiatyChbx"
          checked={kwiaty}
          onChange={() => setKwiaty(!kwiaty)}
        ></input>
        <label htmlFor="kwiatyChbx" className="form-check-label">
          Kwiaty
        </label>
      </div>
      <div className="form-check-inline form-switch">
        <input
          className="form-check-input"
          type="checkbox"
          name="zwierzetaChbx"
          checked={zwierzeta}
          onChange={() => setZwierzeta(!zwierzeta)}
        ></input>
        <label htmlFor="zwierzetaChbx" className="form-check-label">
          Zwierzęta
        </label>
      </div>
      <div className="form-check-inline form-switch">
        <input
          className="form-check-input"
          type="checkbox"
          name="samochodyChbx"
          checked={samochody}
          onChange={() => setSamochody(!samochody)}
        ></input>
        <label htmlFor="samochodyChbx" className="form-check-label">
          Samochody
        </label>
      </div>
      <div className="galeria">
        {kwiaty
          ? zdjecia.map((element, index) => {
              if (element.category == 1)
                return (
                  <div key={index}>
                    <img
                      className="zdjecieBox"
                      src={"./assets/" + element.filename}
                    />
                    <h4>Pobrań: {element.downloads}</h4>
                    <button
                      type="button"
                      className="btn btn-success"
                      onClick={() => {
                        pobierz(index);
                      }}
                    >
                      Pobierz
                    </button>
                  </div>
                );
            })
          : ""}
        {zwierzeta
          ? zdjecia.map((element, index) => {
              if (element.category == 2)
                return (
                  <div key={index}>
                    <img
                      className="zdjecieBox"
                      src={"./assets/" + element.filename}
                    />
                    <h4>Pobrań: {element.downloads}</h4>
                    <button
                      type="button"
                      className="btn btn-success"
                      onClick={() => {
                        element.downloads++;
                        setZdjecia([...zdjecia]);
                      }}
                    >
                      Pobierz
                    </button>
                  </div>
                );
            })
          : ""}
        {samochody
          ? zdjecia.map((element, index) => {
              if (element.category == 3)
                return (
                  <div key={index}>
                    <img
                      className="zdjecieBox"
                      src={"./assets/" + element.filename}
                    />
                    <h4>Pobrań: {element.downloads}</h4>
                    <button
                      type="button"
                      className="btn btn-success"
                      onClick={() => {
                        element.downloads++;
                        setZdjecia([...zdjecia]);
                      }}
                    >
                      Pobierz
                    </button>
                  </div>
                );
            })
          : ""}
      </div>
    </>
  );
}

export default App;
