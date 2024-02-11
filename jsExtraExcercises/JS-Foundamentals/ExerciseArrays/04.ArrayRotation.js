function arrayRotation(array, rotations) {
for (let i = 0; i < rotations; i++) {
   array.push(array[0]);
   array.shift();
}
let result= array.join(' ');
console.log(result);
};

//arrayRotation([32, 21, 61, 1], 4);
