'use strict';

function valuesToIndexes(numbers) {
    let n = numbers.splice(0,1);
    let result = new Array(Number(n));

        for (let i = 0; i < numbers.length; i++) {
        let tokens = numbers[i].split(' - ');
        let key = tokens[0];
        let value = tokens[1];

        result[key] = value;
    }

    for (let i = 0; i < result.length; i++){
        if (result[i] === undefined){
            console.log(0)
        }else{
            console.log(result[i])
        }
    }
}

valuesToIndexes(['2','0 - 5','0 - 6','0 - 7'])
