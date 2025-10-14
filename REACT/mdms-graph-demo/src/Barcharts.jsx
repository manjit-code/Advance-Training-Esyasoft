import React from 'react'
import { BarChart, Bar, XAxis, YAxis, Tooltip, Legend, CartesianGrid } from 'recharts';
export default function BarCharts() {
    const data = [
        {month: "January", sales: 2000},
        {month: "February", sales: 1000},
        {month: "March", sales: 4000}
    ];
  return (
    <div>
      <BarChart width={500} height={300} data = {data}>
            <CartesianGrid strokeDasharrays = "3 3"/>
            <XAxis dataKey="month"/>
            <YAxis/>
            <Tooltip/>
            <Legend/>
            <Bar dataKey="sales" fill="#144eb4ff"/>
      </BarChart>
    </div>
  )
}
