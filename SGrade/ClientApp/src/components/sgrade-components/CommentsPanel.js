import React from 'react'
import Comments from './Comments'
const CommentsPanel = ({ gradable }) => {
    return (
        <>
            {!gradable.isConfirmed ?
                <div className="alert alert-warning m-2 mt-5">
                    Ten kierunek nie został jeszcze zatwierdzony przez użytkowników. <br />
                    Odwiedź *link* i pomóż nam we współtworzeniu strony!
                </div> : <Comments gradable={gradable}/>}

        </>
    )
}

export default CommentsPanel
