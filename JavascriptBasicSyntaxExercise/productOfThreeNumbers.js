function solution(product) {
    let x = Number(product[0]);
    let y = Number(product[1]);
    let z = Number(product[2]);
    let count = 0;

    if (x < 0){
        count++;
    }
    if (y < 0){
        count++;
    }
    if (z < 0){
        count++;
    }


    if (count % 2 != 0){
        console.log('Negative')
    }
    else{
        console.log('Positive')
    }

}

solution(['-3','-4','5'])