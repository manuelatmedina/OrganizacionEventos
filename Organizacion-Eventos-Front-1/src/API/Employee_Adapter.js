import HttpClient from "../Services/HttpClient";

//Gets all employees
export const getListEmployees = () => {
  return new Promise((resolve, reject) => {
    HttpClient.get("/ControladorCiclo/ConsultarCiclo")
      .then((response) => {
        // resolve(response);
        console.log("GetListEmployees check: ", response);
      })
      .catch((error) => {
        // reject(error.response);
        console.log("GetListEmployees error: ", response);
      });
  });
};
