function FilterTweets() {
    var input, filter, ul, li, a, i;
    input = document.getElementById("FiltertweetId");
    filter = input.value.toUpperCase();
    ul = document.getElementById("ListofTweets");
    li = ul.getElementsByTagName("li");
    for (i = 0; i < li.length; i++) {
        if (li[i].innerHTML.toUpperCase().indexOf(filter) > -1) {
            li[i].style.display = "";
        } else {
            li[i].style.display = "none";

        }
    }


}

/*This function is called onload of JSP after displaying all status
* and waits for 60 seconds before it refreshes the top 10 latest tweets*/
function reLoad() {

    window.location.reload();
    return "success";

}