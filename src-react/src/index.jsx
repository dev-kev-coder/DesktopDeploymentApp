import React from 'react';
import { createRoot } from 'react-dom/client';
import { RouterProvider, createMemoryRouter } from 'react-router-dom';
import App from './App';
import Page from './Page';

const root = createRoot(document.getElementById('root'));

const router = createMemoryRouter([
  { path: '/', element: <App />, errorElement: <h1>Error 404</h1> },
  { path: '/page', element: <Page /> },
]);

root.render(
  <React.StrictMode>
    <RouterProvider router={router} />
  </React.StrictMode>,
);
