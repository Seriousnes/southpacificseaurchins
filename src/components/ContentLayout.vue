<template>
    <div>
        <div class="pb-4">
            <h1>
                <slot name="header"></slot>
            </h1>
            <hr />
            <p class="justify-text">
                <slot name="blurb"></slot>
            </p>
        </div>
        <div class="container px-0">
            <slot name="page-content"></slot>
        </div>
    </div>
</template>