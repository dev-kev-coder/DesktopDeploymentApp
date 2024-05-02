import React from 'react';
import PropTypes from 'prop-types';
import { Link } from 'react-router-dom';

const Page = () => {
  return (
    <div>
      <Link to="psdfsdfage">Pages</Link>
    </div>
  );
};

Page.propTypes = {
  propName: PropTypes.any, // Adjust the prop type
};

Page.defaultProps = {
  propName: '', // Set default value
};

export default Page;
