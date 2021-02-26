import React from 'react'
import 'font-awesome/css/font-awesome.min.css';

const StarRating = ({starAmount}) => {
    
    return (
        <div className="row">
            { [...Array(starAmount !== undefined ? Math.floor(starAmount) : 0)].map((_, index) => <i key={index} className="fa fa-star" style={{color: 'orange'}}></i>)}
            { [...Array(starAmount !== undefined ? 5-Math.floor(starAmount) : 5)].map((_, index) => <i key={index} className="fa fa-star" ></i>)}
        </div>
    )
}

export default StarRating


//coś tutaj nie gra, czemu renderujemy się wielokrotnie?