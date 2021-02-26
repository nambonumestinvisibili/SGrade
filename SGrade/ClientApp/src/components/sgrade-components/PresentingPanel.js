import React from 'react'
import Breadcrumb from './Breadcrumb'
import Board from './Board'
import StarRating from './StarRating'


const PresentingPanel = ({gradable}) => {
    return (
        <div id="object-panel" className="container mt-5 pt-5 rounded shadow-lg">
            <Breadcrumb type={gradable.type} />
            <Board name={gradable.name}/>
            <StarRating starAmount={gradable.starsRating}/>
        </div>
    )
}

export default PresentingPanel
