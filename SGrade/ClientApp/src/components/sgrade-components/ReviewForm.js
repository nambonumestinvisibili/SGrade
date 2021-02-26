import React from 'react'
import 'font-awesome/css/font-awesome.min.css';


const ReviewForm = () => {
    return (
        <div className="bg-light rounded p-3">
            <div className="p-1">
                <h5>A Ty, co myślisz?</h5>
            </div>
            <form method="post" >
                <input  value="" type="hidden" /> {/* if of what I review */}
                <input  value="@Model.UserId" type="hidden" />
                <input value="@Model.Username" type="hidden" />
                <div className="row" id="new-comment-section">
                    <div className="form-group col input-field">
                        <input className="review-title form-control" placeholder="Nazwij swoją opinię..." />
                        
                    </div>
                    <div className="form-group col">
                        <div id="star-rating" className="form-group">
                            <span className="fa fa-star"></span>
                            <span className="fa fa-star"></span>
                            <span className="fa fa-star"></span>
                            <span className="fa fa-star"></span>
                            <span className="fa fa-star"></span>
                        </div>
                        <input id="star-form" type="number"  defaultValue="numerofstars" className="d-none form-control" />
                    </div>
                </div>
                <div className="form-group">
                    <textarea  placeholder="Powiedz, co myślisz..."
                        className="form-control rounded" rows="4" /> 
                </div>

                <button type="submit" className="btn btn-outline-primary ml-1 rounded-pill "> <i className="far fa-arrow-alt-circle-right"></i> </button>
            </form>
        </div>
    )
}

export default ReviewForm
