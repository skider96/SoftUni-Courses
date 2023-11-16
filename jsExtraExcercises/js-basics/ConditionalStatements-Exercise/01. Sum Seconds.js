/*Трима спортни състезатели финишират за някакъв брой секунди (между 1 и 50). 
Да се напише функция, която получава три аргумента - секунди и пресмята сумарното им време 
във формат "минути:секунди". 
Секундите да се изведат с водеща нула (2  "02", 7  "07", 35  "35").*/ 

function SumSeconds(input) {
let firstTime = Number(input[0]);
let secondTime = Number(input[1]);
let thirdTime = Number(input[2]);

let totalTime = firstTime + secondTime + thirdTime;
let minutes = Math.floor(totalTime / 60);
let seconds = totalTime % 60;

let formatedSeconds = seconds.toLocaleString('en-US', {
    minimumIntegerDigits: 2,
    useGrouping: false
});

console.log(`${minutes}:${formatedSeconds}`);
}

SumSeconds(["22", "7", 
"34"]);