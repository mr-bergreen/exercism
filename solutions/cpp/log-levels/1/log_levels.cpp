#include <string>

namespace log_line {
std::string message(std::string line) {
    // return the message
    std::string m = line.substr(line.find(" ")+1);
    return m;
}

std::string log_level(std::string line) {
    // return the log level
    int start = line.find("[");
    int end = line.find("]");
    std::string level = line.substr(start+1, end-1);
    return level;
}

std::string reformat(std::string line) {
    // return the reformatted message
    return message(line) + " (" + log_level(line) + ")";
}
}  // namespace log_line
