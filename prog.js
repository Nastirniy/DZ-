let  num = +prompt ('число')

for (let i=num ; i>0 ; i-- ) {
    if (i>0) {    
        if (i % 2 == 0) {
            console.log (i+ ' - ' +  "четное") 
        }else{ console.log (i+ ' - ' +  "не четное") }
       
    } else{ console.log ('введите число больше 0')} 
}