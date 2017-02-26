var sectionIndex;
function getQueryVariable(variable)
{
       var query = window.location.search.substring(1);
       var vars = query.split("&");
       for (var i=0;i<vars.length;i++) {
                      var pair = vars[i].split("=");
                      if(pair[0] == variable){return pair[1];}
              }
       return(false);
}

function init(){
	sectionIndex = getQueryVariable("sectionIndex");
	console.log("Section Index = " + sectionIndex);
	if (!sectionIndex){sectionIndex = 0}
	showSection(sectionIndex);
}


function getSections(){
	var sections = document.querySelectorAll("section");	
	return sections;
}


function showSection(sectionNum){ //sectionNum starts at 0
	var sections = getSections();
	if (sectionIndex < 0 || sectionIndex > sections.length){window.location.href = "?sectionIndex=" + 0;}
	for (i=0;i<sections.length;i++){
		if (i == sectionIndex){
			sections[i].style.display = 'block';
		}else{
			sections[i].style.display = 'none';
		} 
	}

	var nextButton = document.getElementById("nextButton");
	var prevButton = document.getElementById("prevButton");

	if (sectionIndex == 0){
		console.log("section index = 0");
		prevButton.disabled = true;
	}else{
		prevButton.disabled = false;	
	}
	if (sectionIndex == sections.length-1){
		console.log("section index = max");
		nextButton.disabled = true;
	}else{
		nextButton.disabled = false;
	}
}

function nextSection(){
	sectionIndex++;
	window.location.href = "?sectionIndex=" + sectionIndex;
}
function prevSection(){
	sectionIndex--;
	window.location.href = "?sectionIndex=" + sectionIndex;
}
