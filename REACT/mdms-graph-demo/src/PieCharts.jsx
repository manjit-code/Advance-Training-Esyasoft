import React, { useState, useEffect } from 'react';
import { PieChart, Pie, Cell, Tooltip, Legend, ResponsiveContainer } from 'recharts';

export default function PieCharts() {
  const [data, setData] = useState([]);
  const [activeIndex, setActiveIndex] = useState(-1);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    const fetchData = async () => {
      try {
        setLoading(true);
        const response = await fetch('./db.json');
        
        if (!response.ok) {
          throw new Error(`HTTP error! status: ${response.status}`);
        }
        
        const jsonData = await response.json();
        console.log('Fetched data:', jsonData);
        
        // Handle different possible data structures
        const productsData = jsonData.products || jsonData || [];
        setData(productsData);
        
      } catch (err) {
        console.error('Fetch error:', err);
        setError(err.message);
      } finally {
        setLoading(false);
      }
    };
    
    fetchData();
  }, []);

  const colors = ['#0088FE', '#00C49F', '#FFBB28', '#FF8042', '#AF19FF', '#FF5733'];

  const onPieEnter = (_, index) => {
    setActiveIndex(index);
  };

  // Check if data has the expected structure
  const renderChart = () => {
    if (loading) return <div>Loading chart data...</div>;
    if (error) return <div>Error: {error}</div>;
    if (!data || data.length === 0) return <div>No data available</div>;

    // Log data structure for debugging
    console.log('Chart data structure:', data);

    return (
      <ResponsiveContainer width={700} height={500}>
        <PieChart>
          <Pie
            activeIndex={activeIndex}
            data={data}
            dataKey="sales"        
            nameKey="name"   
            cx="50%"
            cy="50%"
            outerRadius={150}
            fill="#8884d8"
            label={({ name, percent }) => `${name}: ${(percent * 100).toFixed(0)}%`}
            onMouseEnter={onPieEnter}
          >
            {data.map((entry, index) => (
              <Cell key={`cell-${index}`} fill={colors[index % colors.length]} />
            ))}
          </Pie>
          <Tooltip formatter={(value) => [`${value}`, 'Sales']} />
          <Legend />
        </PieChart>
      </ResponsiveContainer>
    );
  };

  return (
    <div style={{ width: '100%', height: 400 }}>
      <h3>Products Sales Distribution</h3>
      {renderChart()}
    </div>
  );
}