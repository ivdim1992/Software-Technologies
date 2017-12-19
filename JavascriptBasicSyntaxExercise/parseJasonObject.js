let input = {"name":"Gosho","age":10,"date":"19/06/2005"};

solve(input);

function solve(arr) {
    let students = arr.map(JSON.parse);

    students.forEach(student => {
        let studentStr = `Name: ${student.name}\n` + `Age: ${student.age}\n` + `Date: ${student.date}`;
        console.log(studentStr)
    });

}