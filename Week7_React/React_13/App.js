import React, { useState } from 'react';

function BookDetails() {
  return <h2>Book: “React Mastery” by John Doe</h2>;
}

function BlogDetails() {
  return <h2>Blog: “State vs Props in React”</h2>;
}

function CourseDetails() {
  return <h2>🎓 Course: “Full Stack Web Dev”</h2>;
}

function App() {
  const [view, setView] = useState("blog");

  const renderComponent = () => {
    switch (view) {
      case "book":
        return <BookDetails />;
      case "course":
        return <CourseDetails />;
      default:
        return <BlogDetails />;
    }
  };

  const items = [
    { id: 1, name: "React Basics" },
    { id: 2, name: "JSX Deep Dive" },
    { id: 3, name: "Hooks Explained" }
  ];

  return (
    <div style={{ padding: '20px', background: '#fff5e6', minHeight: '100vh' }}>
      <h1>Blogger App</h1>

      <button onClick={() => setView("book")}>Book</button>
      <button onClick={() => setView("blog")}>Blog</button>
      <button onClick={() => setView("course")}>Course</button>

      <hr />
      {renderComponent()}

      <h3>Topics List (Using map & keys)</h3>
      <ul>
        {items.map(item => (
          <li key={item.id}>{item.name}</li>
        ))}
      </ul>
    </div>
  );
}

export default App;
