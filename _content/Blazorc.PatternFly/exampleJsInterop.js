// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

window.exampleJsFunctions = {
  showPrompt: function (message) {
    return prompt(message, 'Type anything here');
  }
};

// TODO: Move to another place and fix the name.
window.ElementsFunctions = {
    getBoundingClientRect: function(x, y) {
        var elementFromPoint = document.elementFromPoint(x, y);
        if (elementFromPoint === undefined || elementFromPoint == null) {
            return null;
        }

        return elementFromPoint.getBoundingClientRect();;
    }
}
