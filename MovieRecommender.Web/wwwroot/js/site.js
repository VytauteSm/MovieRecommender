/*do we need this?*/

//function selectSearchType(searchType) {
//    const form = document.getElementById('mainForm'); //we cant change value of the form

//    //alert(searchType.value);

//    const searchTypeSelection = document.getElementById('searchTypeSelected');

//    searchTypeSelection.value = "C"; //we do it to control what's happening in the server

//    form.submit(); //data will go to server
//}

//function changeSearchForm(searchType) {
//    //console.log(searchType.value); //we dont need to write in console anymore

//    const searchQuery = document.getElementById('searchQuery');
//    const searchGenreContainer = document.getElementById('searchGenreContainer');

//    if (searchType.value === 'T' || searchType.value === 'K') { //we compare values
//        searchQuery.style.display = 'block';
//        searchGenreContainer.style.display = 'none'; //we want to hide one and show second
//    } else {
//        searchQuery.style.display = 'none';
//        searchGenreContainer.style.display = 'block';
//    }
//}