import React from 'react'
import Review from './Review'
import ReviewForm from './ReviewForm'

const Comments = ({ gradable }) => {
    return (
        <div className='container mt-5'>
            <h2>Opinie o kierunku</h2>
            <div className="row mt-4">

                <div id="major-reviews" className="col-8">
                    {/* if user can comment */}
                    <ReviewForm />
                    {/* if user not logged in */}
                    {0 && <div className="bg-light rounded p-3">
                        <p>Zaloguj się, by komentować</p>
                    </div>}
                    {/* if user cant comment */}
                    {0 && <div className="bg-light rounded p-3">
                        <p>Już komentowałeś!</p>
                    </div>}
                    <div id="placeholder-for-new-review" className="mb-4">
                    </div>

                    {gradable.reviews !== null && gradable.reviews.map((item, index) => <Review key={index} review={{ title: 'tytul', numberofStars: 3, message: 'message', username: 'dawid' }} />)}

                </div>
            </div>
        </div>
    )
}

export default Comments
