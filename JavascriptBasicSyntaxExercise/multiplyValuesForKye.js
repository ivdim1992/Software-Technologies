let input = ['3 test','3 test1','4 test2','4 test3','4 test5','4'];

solve(input);

function solve(arr) {
    let lastKey = arr.splice(arr.length - 1,1)[0];
    let dictionary = [{}];
    arr.forEach(elemen => {
        let tokens = elemen.split(' ');
        let key = tokens[0];
        let value = tokens[1];

       // dictionary[key] = value;

        if(!dictionary.hasOwnProperty(key)){
            dictionary[key] = [value];
        }else{
            dictionary[key].push(value)
        }
        
    });

    if (dictionary.hasOwnProperty(lastKey)){
        dictionary[lastKey].forEach(element => {
            console.log(element)
        })
    }else{
        console.log("None")
    }
}