import axios from "axios";

axios.defaults.baseURL = "https://localhost:7000/api/";

const requestGenerico = {
  get: (url) => axios.get(url),
  post: (url, body) => axios.post(url, body),
  put: (url, body) => axios.put(url, body),
  delete: (url, body = null) => {
    if (body !== null) {
      return axios.delete(url, { data: body });
    } else {
      return axios.delete(url);
    }
  },
};

export default requestGenerico;
