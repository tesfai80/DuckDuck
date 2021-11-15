import React from "react";
import {AppBar, Toolbar, Typography} from '@material-ui/core';

function Header(){
    return (
      <AppBar position='absolute'>
         <Toolbar>
             <Typography>DuckDuck Search Engine</Typography>
         </Toolbar>
      </AppBar>

    );
}
export default Header;