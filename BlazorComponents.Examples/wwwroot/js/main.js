// ====================================================================
// Modal

function lockScrollBody(isHidden) {
    if (isHidden) {
        $("body").removeClass(" scroll-locked");
    }
    else {
        $("body").addClass(" scroll-locked");
    }
}

// ====================================================================
// Modal

function setDataTable(elem) {
    $(document).ready(function () {
        $(elem).DataTable();
    });
}

// ====================================================================