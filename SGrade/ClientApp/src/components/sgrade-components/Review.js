import React from 'react'
import StarRating from './StarRating'

const Review = ({ review }) => {
    return (
        <div className='card m-2 box-shadow'>
            <div className='card-body'>
                <div className='col-8'>
                    <h4 className='card-title border-bottom pt-4 pl-3 pb-3'>
                        {review.title}
                    </h4>
                </div>
                {/* <p className='pl-3'> */}
                    <StarRating starAmount={review.numberofStars}/>
                {/* </p> */}
                <p className='card-text pl-3 pt-2 pb-4 border-left border-primary'>
                    {review.message}
                </p>
                <p className='card-text pl-3 border-left border-secondary text-secondary'>
                    {review.username}
                </p>
            </div>
            
        </div>
    )
}

export default Review 
