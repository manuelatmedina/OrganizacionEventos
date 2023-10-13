import React, { useEffect } from "react";
import { Navbar_Component } from "./Components";
import { getListEmployees } from "./API/Employee_Adapter";

function App() {
  useEffect(() => {
    const getList = async () => {
      await getListEmployees();
    };

    getList();
  }, []);

  return (
    <>
      <Navbar_Component />
    </>
  );
}

export default App;
