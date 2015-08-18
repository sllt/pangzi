## the Pangzi Programming Language

like [Brainfuck](https://en.wikipedia.org/wiki/Brainfuck) .

## Commands
The eight language commands:

|  phrase | meaning |
|---|---|
| pangzi  | increment the byte at the data pointer.  |
| PangZi  | decrement the byte at the data pointer.  |
| PANGZII  | output the byte at the data pointer.  |
| snpangzi  | increment the data pointer.  |
| nspangzi  | decrement the data pointer.  |
| pangZii  | accept one byte of input.  |
| zpangzi  | if the byte at the data pointer is zero, then instead of moving the instruction pointer forward to the next command, jump it forward to the command after the matching `zpangzi` command.  |
| hpangzi  | if the byte at the data pointer is nonzero, then instead of moving the instruction pointer forward to the next command, jump it back to the command after the matching `hpangzi` command. |


## Running

```
$ mono pangzi helloworld.pz
```