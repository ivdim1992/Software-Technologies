let input = ['3 test','3 test1','4 test2','4 test3','4 test5','4'];

solve(input);

function solve(arr) {
    let lastKey = arr.splice(arr.length - 1,1)[0]
    let dictionary = {};
    arr.forEach(element => {
        let tokens = element.split(' ');
        let key = tokens[0];
        let value = tokens[1];

        dictionary[key] = value;
    })

    if(dictionary.hasOwnProperty(lastKey)){
        console.log(dictionary[lastKey])
    }else {
        console.log("None")
    }
}