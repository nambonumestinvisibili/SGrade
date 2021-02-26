import React from 'react'

const Breadcrumb = ({type}) => {
    return (
        <div aria-label='breacrumb'>
            <ol className='breadcrumb bg-transparent border-bottom'>
                <li className='breadcrumb-item active text-white'>
                    <a href='#top'>University</a>
                </li>
                {(type === 'Major' || type === 'Teacher' || type === 'Subject') ? <li className='breadcrumb-item active text-white'>
                    <a href='#top'>Major</a>
                </li> : ''}
                {(type === 'Teacher' || type === 'Subject') ? <li className='breadcrumb-item active text-white'>
                    <a href='#top'>Subject</a>
                </li> : ''}
            </ol>
        </div>
    )
}

export default Breadcrumb
