let input = (`name -> Angel\n` + `surname -> Georgiev\n` + `age -> 20\n` + `grade -> 6.00\n` + `date -> 23/05/1995\n` + `town -> Sofia`).split('\n');

solve(input);
function solve(arr) {
    let result = {};

    arr.map(a => a.split(' -> ')).forEach(students => {
        let property = students[0];
        let value = isNaN(students[1]) ? students[1] : Number(students[1]);

        result[property] = value;
    });
    console.log(JSON.stringify(result));
}