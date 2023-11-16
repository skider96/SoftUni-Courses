function BonusScore(startingScore) {
let bonus = 0.0;
let score = Number(startingScore);
switch (true) {
    case score <= 100:
        bonus =  5;
        break;
    case score > 100 && score <= 1000:
        bonus = score * 0.2;
        break;
    case score > 1000:
        bonus = score * 0.1;
        break;
}

if (bonus % 2 == 0) {
    bonus++;
}
else if (bonus % 10 == 5) {
    bonus += 2;
}

console.log(bonus);
console.log(score + bonus);
}

