function Clock (input) {
  let hours = Number(input[0])
  let minutes = Number(input[1])
  let minutesAfter = minutes + 15;
  if (hours > 23) hours = hours % 23
  if (minutesAfter > 59) {
    minutesAfter = minutesAfter % 60
    if (hours === 23) hours = 0
    else hours++
  }
  let formattedSeconds = minutesAfter.toLocaleString('en-US', {
    minimumIntegerDigits: 2,
    useGrouping: false
  })
  console.log(`${hours}:${formattedSeconds}`)
}
Clock(["9", "16"]);
