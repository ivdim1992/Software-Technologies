let input = ['add 3','add 7','add 8'];

solve(input);
function solve(arr) {
    let result = [];

    arr.forEach(element => {
        let tokens = element.split(' ');
        let command = tokens[0];
        let value = Number(tokens[1]);

        if (command === 'add'){
            result.push(value)
        }else {
            result.splice(value,1);
        }
    });

    result.forEach(element => console.log(element))
}

