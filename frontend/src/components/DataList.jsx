import { useState, useEffect } from "react";
import axios from "axios";

function DataList() {
  const [contacts, setContacts] = useState([]);
  const [error, setError] = useState(null);

  useEffect(() => {
    axios("http://localhost:8000")
      .then((response) => {
        setError(null);
        setContacts(response.data);
      })
      .catch(setError);
  }, []);

  if (error) return <p>An error occurred</p>;

  return (
    <div>
      {contacts.map((contact) => 
        <h2>{contact.id}</h2>
      )}
    </div>
  );
}

export default DataList;
