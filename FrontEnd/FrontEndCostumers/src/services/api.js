import axios from 'axios';

const API_BASE_URL = 'https://api.example.com';

export const fetchUserData = async () => {
  const response = await axios.get(`${API_BASE_URL}/user`);
  return response.data;
};

export const fetchPlotsData = async () => {
  const response = await axios.get(`${API_BASE_URL}/plots`);
  return response.data;
};
