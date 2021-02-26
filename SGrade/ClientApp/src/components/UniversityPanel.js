import React from "react";
import PresentingPanel from './sgrade-components/PresentingPanel'
import CommentsPanel from './sgrade-components/CommentsPanel'

const GradablePanel = ({gradable}) => {
    return (
        <div>
            <PresentingPanel gradable={gradable} />
            <CommentsPanel gradable={gradable}/>
        </div>
    )
}

export default GradablePanel